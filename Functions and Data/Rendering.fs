
namespace Functions_and_Data
open System.Drawing
open Data
module Rendering =

// This type system may need reworking, but there is a ton to implement.
    type Renderer =
                {
                    Name : string
                    DisplayName : string
                    Resolution : int * int
                    NodeApply : Node -> Renderer
                    Apply : Renderer -> Renderer


                
                }
    type SVGRenderer = 
        {
           Renderer : Renderer
           SimpleRender : Node -> string
           FinalPass : Renderer -> string

        }

    type RasterRenderer = 
        {   

            Renderer : Renderer
            SimpleRender : Node -> Bitmap
            FinalPass : Renderer -> Bitmap

        }


