
namespace Library
{
    public class PersonaContent 
    {
        private Persona persona;

        public PersonaContent(Persona persona)
        {
            this.persona = persona;
        }

        public string GetTextToPrint()
        {
            Visitor visitor = new PersonaContentVisitor();
            this.persona.Accept(visitor);
            return visitor.Content;
        }
    }
}