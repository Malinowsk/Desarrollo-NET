using System.Collections.Generic;

public abstract class GestorEstaciones{
    protected List<Comida> comidas;
    protected string nombre = "Estacion: ";

    public GestorEstaciones(){
        this.comidas = new List<Comida>();
    }

    public string getNombre(){
        return this.nombre;
    }
    public List<Comida> getComidas(){
        return new List<Comida>(this.comidas);
    }
    public abstract void add(Comida comida);
}