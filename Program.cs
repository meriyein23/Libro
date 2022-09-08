//creacion de clases con los atributos de un libro
public class libro{
    private string titulo, autor;
    private int IBSN, npages;

//creacion de get que  se ejecuta cuando se lee la propiedad.  
    public string gettitulo(){
        return (this.titulo);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public string settitulo(string nombrel){
        return this.titulo=nombrel;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public string getautor(){
        return (this.autor);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public string setautor(string nombrea){
        return this.autor=nombrea;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public int getIBSN(){
        return (this.IBSN);
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public int setIBSN(int ncode){
        return this.IBSN=ncode;
}
//creacion de get que  se ejecuta cuando se lee la propiedad.
    public int getnpages(){
        return this.npages;
    }
//creacion de set que se ejecuta cuando se asigna un nuevo valor a la propiedad
public int setnpages(int npagi){
        return this.npages=npagi;
}
//creacion de la consulta por autor de libro
public void tostring(){ 
    Console.WriteLine("El libro "+this.titulo+" con ISBN "+this.IBSN+" creado por el autor "+this.autor+" tiene "+this.npages+" páginas.");
}
}
