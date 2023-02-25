using System.Collections.Generic;

namespace Despacho.Cocina{
public class Cocina{
    private List<CriterioCobro> criteriosDeCobro;
    private string nombre;
    private Pedido pedido;
    private List<GestorEstaciones> estaciones;

    public Cocina(string nombre, Pedido pedido){
        GestorEstaciones nueva = new EstacionPDefecto();
        this.criteriosDeCobro = new List<CriterioCobro>();
        this.nombre = nombre;
        this.pedido = pedido;
        this.estaciones = new List<GestorEstaciones>();
        estaciones.Add(nueva);
    }
    public List<CriterioCobro> getCriteriosDeCobro(){
        return new List<CriterioCobro>(this.criteriosDeCobro);
    }
    public void addCriterioDeCobro(CriterioCobro c){
        this.criteriosDeCobro.Add(c);
    }
    public void addEstacion(GestorEstaciones nueva){
        if(!nueva.getNombre().Equals("Estacion: POR DEFECTO"))
            this.estaciones.Insert(1, nueva);
    }
    public List<GestorEstaciones> GetGestorEstaciones(){
        return new List<GestorEstaciones>(this.estaciones);
    }
    public string getNombre(){
        return this.nombre;
    }
    public void setNombre(string nombre){
        this.nombre = nombre;
    }
    public Pedido getPeido
    public
    public
    public
}

}