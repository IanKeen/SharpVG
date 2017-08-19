# SharpVG

[![Join the chat at https://gitter.im/SharpVG/Lobby](https://badges.gitter.im/SharpVG/Lobby.svg)](https://gitter.im/SharpVG/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

A .NET Core library for F# to generate vector graphics in SVG format.

## Why SharpVG?

 - Allows you to emit SVG using simple F# commands so that you can create graphics and animations that are easy to distribute
 - Ability to render dynamically using [Fable](http://fable.io) to create interactive web pages
 - All basic SVG elements are supported: line, circle, ellipse, rect, text, polygon, polyline, path, image, and groups
 - No understanding of SVG is required and its as easy as using seq, list, or array
 - No external dependencies other than SharpVG are required
 - .NET Core cross platform support on Windows, Linux, and OSX
 - Limited support for SVG animations
 - Limited support for cartesian plotting
 - Reusable styles

## Examples

```F#
let upperLeft = Point.ofInts (10, 10)
let area = Area.ofInts (50, 50)
let style = Style.create (Name Colors.Cyan) (Name Colors.Blue) (Length.ofInt 3) 1.0

Rect.create upperLeft area
  |> Element.ofRect
  |> Element.withStyle style
  |> Element.toString
  |> printf "%A"
```

```html
<circle r="10" cx="0" cy="0"/>
```

```F#
let center = Point.ofInts (60, 60)
let radius = Length.ofInt 50
let style = Style.create (Name Colors.Violet) (Name Colors.Indigo) (Length.ofInt 3) 1.0

Circle.create center radius
  |> Element.ofCircle
  |> Element.withStyle style
  |> Svg.ofElement
  |> Svg.toHtml "Example"
  |> printf "%A"
```

```html
<!DOCTYPE html>
<html>
<head>
<title>Example</title>
</head>
<body>
<svg><circle r="10" cx="0" cy="0"/></svg>
</body>
</html>
```

## Building SharpVG

Clone the repository:
```bash
git clone https://github.com/ChrisNikkel/SharpVG.git
cd SharpVG
```

Start the build:
```bash
dotnet build
```

Run the tests:
```bash
dotnet test Tests
```

Run the examples:
```bash
dotnet run -p Examples\Triangle\Triangle.fsproj
dotnet run -p Examples\Life\Life.fsproj
dotnet run -p Examples\Graph\Graph.fsproj
dotnet run -p Examples\Animate\Animate.fsproj
```

Explore interactively:
```bash
fsharpi -r:SharpVG/bin/Debug/netcoreapp2.0/SharpVG.dll
```
```F#
open SharpVG;;
Circle.create Point.origin (Length.ofInt 10) |> Circle.toString |> printf "%A";;
Circle.create Point.origin (Length.ofInt 10) |> Element.ofCircle |> Svg.ofElement |> Svg.toHtml "Example";;
#quit;;
```

## Support

 - Please submit bugs and feature requests [here](https://github.com/ChrisNikkel/SharpVG/issues)

## Library License

The library is available under the MIT license. For more information see the [License file](https://github.com/ChrisNikkel/SharpVG/blob/master/LICENSE.md).

## Maintainer(s)

- [@ChrisNikkel](https://github.com/ChrisNikkel)
