namespace Library
{
    public class PersonaContentVisitor : Visitor
    {
        public override void Visit(Persona persona)
        {
            this.ContentBuilder.Clear();
            this.ContentBuilder.Append($"Edad: {persona.Edad}\n");
        }
    }
}