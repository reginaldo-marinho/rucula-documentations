using System.Collections.Generic;
namespace Rucula.Domain;
public class LanguageRucula
{
    public LanguageRucula(string code, string description,string description2,string atributesDefaut)
    {
        ValidateProperts(code, description,description,atributesDefaut);
    }
    public string Code { get; private set; }
    public string Description { get; private set; }
    public string Description2 { get; private set; }
    public string AtributesDefaut { get; private set; }
    public LanguageRuculaRepresentation LanguageRuculaRepresentation {get;set;}

    private void ValidateProperts(string code, string description, string description2, string atributesDefaut)
    {
        ValidationPropert.ValidPropert(String.IsNullOrEmpty(code),"code is Invalid");
        ValidationPropert.ValidPropert(code.Length > 100,"Character overflow, max 100");
        ValidationPropert.ValidPropert(description.Length > 200,"Character overflow, max 200");
        ValidationPropert.ValidPropert(description2.Length > 200,"Character overflow, max 200");
        ValidationPropert.ValidPropert(atributesDefaut?.Length > 300,"Character overflow, max 300");
        this.Code = code;
        this.Description = description;
        this.Description2 = description2;
        this.AtributesDefaut = atributesDefaut;
    }
}