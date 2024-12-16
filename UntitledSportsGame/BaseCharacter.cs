/* Am so f'ing proud of this, kills 3 bird with 1 stone but on GAWD why dafuq does it have 21 WARNINGS!
/ WHY ARE YOU THE WAY YOU ARE!!!! */
public abstract class BaseCharacter{
    private string name;
    private string gender;
    private string age;
    private string bodyType;
    private string height;
    private string skinColor;
    private string hairType;
    private string hairColor;
    private string eyeColor;
    private string headgear;
    private string top;
    private string pants;
    private string shoes;
    private string accessories;
    private bool facePaint;
    private string bat;
    private string gloves;
    private string physicalClass;
    private string mentalClass;
    private string specialTrait;
    private string teamName;
    private int jerseyNumber;

    /*  Getters & Setters   */
    protected string Name{ get{ return this.name; } set{ this.name = value; }}
    protected string Gender{ get{ return this.gender; } set{ this.gender = value; }}
    protected string Age{ get{ return this.age; } set{ this.age = value; }}
    protected string BodyType{ get{ return this.bodyType; } set{ this.bodyType = value; }}
    protected string Height{ get{ return this.height; } set{ this.height = value; }}
    protected string SkinColor{ get{ return this.skinColor; } set{ this.skinColor = value; }}
    protected string HairType{ get{ return this.hairType; } set{ this.hairType = value; }}
    protected string HairColor{ get{ return this.hairColor; } set{ this.hairColor = value; }}
    protected string EyeColor{ get{ return this.eyeColor; } set { this.eyeColor = value; }}
    protected string Headgear{ get{ return this.headgear; } set{ this.headgear = value; }}
    protected string Top{ get{ return this.top; } set{ this.top = value; }}
    protected string Pants{ get{ return this.pants; } set{ this.pants = value; }}
    protected string Shoes{ get{ return this.shoes; } set{ this.shoes = value; }}
    protected string Accessories{ get{ return this.accessories; } set{ this.accessories = value; }}
    protected bool FacePaint{ get{ return this.facePaint; } set{ this.facePaint = value; }}
    protected string Bat{ get{ return this.bat; } set{ this.bat = value; }}
    protected string Gloves{ get{ return this.gloves; } set{ this.gloves = value; }}
    protected string PhysicalClass{ get{ return this.physicalClass; } set{ this.physicalClass = value; }}
    protected string MentalClass{ get{ return this.mentalClass; } set{ this.mentalClass = value; }}
    protected string SpecialTrait{ get{ return this.specialTrait; } set{ this.specialTrait = value; }}
    protected string TeamName{ get{ return this.teamName; } set{ this.teamName = value; }}
    protected int JerseyNumber{ get{ return this.jerseyNumber; } set{ this.jerseyNumber = value; }}

    public abstract void CharacterCustomization();

    public virtual void ShowcaseCharacterInfo(){
        Console.Clear();
        Console.WriteLine("===== Character =====");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Body Type: {bodyType}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Skin Color: {skinColor}");
        Console.WriteLine($"Hair Type: {hairType}");
        Console.WriteLine($"Hair Color: {hairColor}");
        Console.WriteLine($"Eye Color: {eyeColor}");
        Console.WriteLine($"Headgear: {headgear}");
        Console.WriteLine($"Top: {top}");
        Console.WriteLine($"Pants: {pants}");
        Console.WriteLine($"Shoes: {shoes}");
        Console.WriteLine($"Accessories: {accessories}");
        Console.WriteLine($"Has Face Paint: {facePaint}");
        Console.WriteLine($"Baseball Bat: {bat}");
        Console.WriteLine($"Pitching Gloves: {gloves}");
        Console.WriteLine($"Physical Class: {physicalClass}");
        Console.WriteLine($"Mental Class: {mentalClass}");
        Console.WriteLine($"Special Trait: {specialTrait}");
        Console.WriteLine($"Team Name: {teamName}");
        Console.WriteLine($"Jersey Number: {jerseyNumber}");
    }
}