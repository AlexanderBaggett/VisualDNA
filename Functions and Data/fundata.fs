namespace Functions_and_Data
open System.Drawing

module Data =
    type VectorImage = class end
    type SliderDisplayType = 
                             |Slider 
                             |TextBox
    type SliderOption = { Name: string
                          Current : float
                          Min : float
                          Max : float
                          DisplayType : SliderDisplayType
                          Adjust : float -> SliderOption
                
                          }


    type CheckedOption = { Name: string
                           Checked : bool
                           Adjust : bool -> CheckedOption
                          
                          }
    type RadioOption = {   Name: string
                           Options : (string * bool) list
                           Adjust : string * bool-> RadioOption
                          
                          }
    type Node = 
    
        {
          Name :string
          DisplayName : string
          ParentNodes : Node list
          ChildNodes : Node list
          Vector2D :  VectorImage
          SliderOptions : SliderOption list
          CheckedOptions : CheckedOption list
          RadioOptions : RadioOption list
          Preview : Bitmap
          InputNames : string list
          Command : Node list -> Node

        
        }
module Commands = 
    do ()

module Nodes =
    module Generate =
        do ()
    module Transform =
        do ()
    module Filter =
        do ()