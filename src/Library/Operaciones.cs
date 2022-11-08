namespace Library
{
    public interface Operaciones
    {
        void Accept (Visitor1 visitor);
        void Accept (Visitor2 visitor);
    }
}