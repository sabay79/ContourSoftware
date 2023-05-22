using AutoMapper;
using OBS.Business.Interfaces;
using OBS.Data.Interfaces;

namespace OBS.Business.Services
{
    public class Service<TModel, TEntity> : IService<TModel> where TEntity : class
    {
        private readonly IUnitOfWork<TEntity> _unitOfWork;
        private readonly IMapper _mapper;
        public Service(IUnitOfWork<TEntity> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<TModel> GetAll()
        {
            var allEntities = _unitOfWork.Repository.GetAll();
            var allModels = _mapper.Map<List<TModel>>(allEntities);
            return allModels;
        }

        public TModel GetByID(int id)
        {
            var entity = _unitOfWork.Repository.GetByID(id);
            var model = _mapper.Map<TModel>(entity);
            return model;
        }

        public void Add(TModel model)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(model);
                _unitOfWork.Repository.Add(entity);
                _unitOfWork.Repository.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Update(TModel model)
        {
            try
            {
                var entity = _mapper.Map<TEntity>(model);
                _unitOfWork.Repository.Update(entity);
                _unitOfWork.Repository.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var entity = _unitOfWork.Repository.GetByID(id);
                if (entity != null)
                {
                    _unitOfWork.Repository.Delete(entity);
                    _unitOfWork.Repository.Save();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}