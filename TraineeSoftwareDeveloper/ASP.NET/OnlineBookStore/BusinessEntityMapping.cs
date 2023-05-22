using System;

public class BusinessEntityMapping
{
    public BusinessEntityMapping()
    {
        CreateMap<AuthorModel, Author>().ReverseMap();
    }
}
