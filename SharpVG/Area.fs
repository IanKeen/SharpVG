namespace SharpVG

type Area =
    {
        Width : Length;
        Height : Length;
    }

[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module Area =
    let create width height =
        { Width = width; Height = height }

    let toAttributes area =
        set[Attribute.create "height" <| Length.toString area.Height; Attribute.create "width" <| Length.toString area.Width]

    let toString area =
        Length.toString area.Height + "," + Length.toString area.Width
