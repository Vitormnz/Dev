using System;
namespace CarroObj
{
  public class Carro
  {
    private string name = "Astra";
    private string placa = "ASD-123";

    public string getName()
    {
      return name;
    }

    public void setName(string name)
    {
      this.name = name;
    }

    public string getPlaca()
    {
      return placa;
    }

    public void setPlaca(string placa)
    {
      this.placa = placa;
    }

    public string toString()
    {
      return "Carro: " + name + " Placa " + placa;
    }
  }
}