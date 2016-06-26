namespace SharpVG

type Point =
    {
        X : Length;
        Y : Length;
    }

[<CompilationRepresentation (CompilationRepresentationFlags.ModuleSuffix)>]
module Point =
    let create x y =
        { X = x; Y = y }

    let toFloats point =
        (Length.toFloat point.X, Length.toFloat point.Y)

    let toDoubles point =
        (Length.toDouble point.X, Length.toDouble point.Y)

    let toAttributesWithModifier point pre post =
        set [Attribute.create (pre + "x" + post) (Length.toString point.X); Attribute.create (pre + "y" + post) (Length.toString point.Y)]

    let toAttributes point =
        toAttributesWithModifier point "" ""

    let toStringWithSeparator separator point =
        Length.toString point.X + separator + Length.toString point.Y

    let toString =
        toStringWithSeparator ","
