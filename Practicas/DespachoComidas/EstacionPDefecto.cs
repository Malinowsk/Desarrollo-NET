public class EstacionPDefecto : GestorEstaciones{
    public EstacionPDefecto(){
        this.nombre += "POR DEFECTO";
    }
    public override void add(Comida comida){
        comidas.Add(comida);
    }

}