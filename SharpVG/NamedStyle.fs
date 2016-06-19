﻿namespace SharpVG

type NamedStyle = {
    Name : string;
    Style : Style;
}

[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module NamedStyle =
    let ofStyle name style =
        { Name = name; Style = style }

    let toCssString namedStyle =
        "." + namedStyle.Name + "{" + (namedStyle.Style |> Style.toCssString) + "}"

    let toTag namedStyle =
        {
            Name = "style";
            Attribute = Some("type=" + (Tag.quote "text/css"));
            Body = Some("<![CDATA[" + (toCssString namedStyle) + "]]>")
        }

    let toString = toTag >> Tag.toString