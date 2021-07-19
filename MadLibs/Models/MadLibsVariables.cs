namespace MadLibs.Models
{
  public class MadLibTemplate
  {
    public string Name { get; set; }
    public string Place { get; set; }
    public string Thing { get; set; }
    public string Animal { get; set; }
    public string Hobby { get; set; }

    public MadLibTemplate() {}
    public MadLibTemplate(
      string name,
      string place,
      string thing,
      string animal,
      string hobby
    )
    {
      Name = name;
      Place = place;
      Thing = thing;
      Animal = animal;
      Hobby = hobby;
    }
  }
}