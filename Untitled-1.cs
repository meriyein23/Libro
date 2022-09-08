// se nombra una clase
public class Bibliotequeria{
    // el main da inicio al algoritmo
	public static void Main(string[] args){
        // se crea una nueva instancia
		libro LaIslaDelTesoro=new libro ();
        // Joa profe usted sabe que se crea una nueva instancia
		libro ViajeAlCentroDeLaTierra=new libro ();

        // se le agregan valores a los set
		LaIslaDelTesoro.setautor("Robert Louis Stevenson");
        // se le agregan valores a los set
		LaIslaDelTesoro.settitulo("La Isla Del Tesoro");
        // se le agregan valores a los set
		LaIslaDelTesoro.setIBSN(97801);
        // se le agregan valores a los set
		LaIslaDelTesoro.setnpages(283);
        // se llama al atributo tostring
        LaIslaDelTesoro.tostring();

		// se le agregan valores a los set
        ViajeAlCentroDeLaTierra.setautor("Julio Verne");
        // se le agregan valores a los set
		ViajeAlCentroDeLaTierra.settitulo("Viaje Al Centro De La Tierra");
        // se le agregan valores a los set
		ViajeAlCentroDeLaTierra.setIBSN(97807);
        // se le agregan valores a los set
		ViajeAlCentroDeLaTierra.setnpages(350);
        // se llama al atributo tostring
        ViajeAlCentroDeLaTierra.tostring();

// inicia el condicional IF estableciendo las reglas
             	if (LaIslaDelTesoro.getnpages() >= ViajeAlCentroDeLaTierra.getnpages()) {
                    // Establece la accion que se hara por verdadero
                	Console.WriteLine ("La Isla Del Tesoro Tiene Mas Paginas");
            	}
		else {
            // Establece la accion por falso
                	Console.WriteLine ("Viaje Al Centro De La Tierra Tiene Mas Paginas");
            	}
// fin condicional
	}
    // fin algoritmo
}
