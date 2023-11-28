import './App.css'
import Card from './components/Card';

function App() {
  return (
    <>
      <a 
        className="text-3xl font-bold bg-green-400 p-5 rounded-xl mb-5" 
        href="https://www.youtube.com/watch?v=bB6707XzCNc&list=PLu71SKxNbfoDqgPchmvIsL4hTnJIrtige&index=7">
        Tailwind and Props in ReactJS
      </a>
      
      <Card />
      <br />
      <Card imgSource='https://images.unsplash.com/photo-1586953208448-b95a79798f07?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D' product='Smart Phone' btnText='Add To Cart' />
      <br />
      <Card imgSource='https://images.unsplash.com/photo-1498050108023-c5249f4df085?q=80&w=1472&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D' product='Laptop' btnText='View Details' />
    </>
  )
}

export default App;
