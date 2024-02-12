using Gehtsoft.PDFFlow.Builder;
using Gehtsoft.PDFFlow.Models.Enumerations;
using Gehtsoft.PDFFlow.Utils;

DocumentBuilder.New().AddSection()
    .SetSize(PaperSize.A4)
    .SetOrientation(PageOrientation.Landscape)
    .SetMargins(50)
    .SetStyleFont(font: Fonts.Courier(20))

    .AddParagraph("Latte").SetListNumbered()
    .ToSection()
    .AddParagraph("Black Coffee").AddPageNumber().ToDocument()
    
    
    
    .Build("CoffeePDF.PDF");
   
   