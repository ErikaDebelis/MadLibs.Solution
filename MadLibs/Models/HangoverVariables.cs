namespace Hangover.Models
{
  public class HangoverTemplate
  {
    public string Name { get; set; }
    public string Place { get; set; }
    public string Thing { get; set; }
    public string Animal { get; set; }
    public string Hobby { get; set; }

    public HangoverTemplate() {}
    public HangoverTemplate(
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