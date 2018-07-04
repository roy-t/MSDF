# MSDF
A signed distance field font sample for monogame.

![Sample](https://raw.githubusercontent.com/roy-t/MSDF/master/gallery.PNG "Sample")

This sample shows how you can integrate [msdfgen](https://github.com/Chlumsky/msdfgen) into your content pipeline to generated signed distance field fonts, and how to correctly render these fonts. Including correct kerning courtesy of my [TrueType library](https://github.com/roy-t/TrueType). 

For more info visit my [blog](https://roy-t.nl).

## The content pipeline project
This sample includes a content pipeline project compatible with Monogame 3.0+. The content processor requires you set the path to the msdfgen binary. I recommend you generate it from [this fork](https://github.com/ckohnert/msdfgen) as it fixes many issues with complicated fonts. 

## The game project
The game project contains a simple utility class and shader to draw 3D moving text.


# Why (multi-channel) signed distance fields?

Signed distance fields are a technique first described by Valve in [this paper](https://steamcdn-a.akamaihd.net/apps/valve/2007/SIGGRAPH2007_AlphaTestedMagnification.pdf). In short a signed distance field is a sort-of height map. Where sea-level are the actually boundaries of the glyph. Everything above sea level is outside the glyph, and everything below sea level is inside the glyph. When a height map is upscaled the GPU fills in the gaps using linear interpolation. The linear interpolation of the height map introduces less noise/faults than interpolating a sharp boundary would do, but we still get the same information.

Traditional signed distance fields only use one channel, but they sometimes have trouble representing sharp corners. Multi-channel signed distance fields solve this problem by using three color channels to store slope information.

# Advantages

- High quality text rendering 
- Low memory usage
- Fast rendering (the shader is very simple)

# Drawbacks

- No automatic mechanism to determine the right signed distance field size to capture all details
- No multi-color glyphs (like emoji)
- Straight lines might look slightly wavery sometimes

# Alternatives

- SpriteFonts, the standard in XNA and MonoGame, look good when rendered at the same size as the sprites were saved, but upscaling and downscaling quickly leads to a serious degradation in quality.
- A library like [slug](http://sluglibrary.com/) which renders text directly from the outline data in the font. So no details are missed and no manual configuration is required.