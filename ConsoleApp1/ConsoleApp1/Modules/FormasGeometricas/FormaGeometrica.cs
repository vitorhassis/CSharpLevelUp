namespace ConsoleApp1.Modules.FormasGeometricas
{
    public abstract class FormaGeometrica
    {
        public abstract void CalculoArea();

        public abstract void CalculoPerimetro();

        //virtual permite que o metodo herdado possa ser redefinido
        public virtual void ExibirDados()
        {
            CalculoArea();
            CalculoPerimetro();
        }
    }
}
