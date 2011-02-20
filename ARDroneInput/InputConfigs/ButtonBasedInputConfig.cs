﻿/* ARDrone Control .NET - An application for flying the Parrot AR drone in Windows.
 * Copyright (C) 2010 Thomas Endres, Stephen Hobley, Julien Vinel
 * 
 * This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with this program; if not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Text;
using ARDrone.Input.InputControls;

namespace ARDrone.Input.InputConfigs
{
    public class ButtonBasedInputConfig : InputConfig
    {
        public ButtonBasedInputConfig()
            : base()
        {
            SetStates();
        }

        private void SetStates()
        { 
            states.Add("leftHeader", new InputConfigHeader("Axes", InputConfigState.Position.LeftColumn, 0));
            states.Add(ButtonBasedInputControl.RollAxisField, new InputValueTextBoxConfigState("Roll", InputConfigState.Position.LeftColumn, 1, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.ContinuousValue));
            states.Add(ButtonBasedInputControl.PitchAxisField, new InputValueTextBoxConfigState("Pitch", InputConfigState.Position.LeftColumn, 2, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.ContinuousValue));
            states.Add(ButtonBasedInputControl.YawAxisField, new InputValueTextBoxConfigState("Yaw", InputConfigState.Position.LeftColumn, 3, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.ContinuousValue));
            states.Add(ButtonBasedInputControl.GazAxisField, new InputValueTextBoxConfigState("Gaz", InputConfigState.Position.LeftColumn, 4, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.ContinuousValue));

            states.Add("rightHeader", new InputConfigHeader("Buttons", InputConfigState.Position.RightColumn, 0));
            states.Add(ButtonBasedInputControl.CameraSwapButtonField, new InputValueTextBoxConfigState("Change Camera", InputConfigState.Position.RightColumn, 1, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.BooleanValue));
            states.Add(ButtonBasedInputControl.TakeOffButtonField, new InputValueTextBoxConfigState("Take Off", InputConfigState.Position.RightColumn, 2, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.BooleanValue));
            states.Add(ButtonBasedInputControl.LandButtonField, new InputValueTextBoxConfigState("Land", InputConfigState.Position.RightColumn, 3, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.BooleanValue));
            states.Add(ButtonBasedInputControl.HoverButtonField, new InputValueTextBoxConfigState("Hover", InputConfigState.Position.RightColumn, 4, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.BooleanValue));
            states.Add(ButtonBasedInputControl.EmergencyButtonField, new InputValueTextBoxConfigState("Emergency", InputConfigState.Position.RightColumn, 5, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.BooleanValue));
            states.Add(ButtonBasedInputControl.FlatTrimButtonField, new InputValueTextBoxConfigState("Flat Trim", InputConfigState.Position.RightColumn, 6, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.BooleanValue));
            states.Add(ButtonBasedInputControl.SpecialActionButtonField, new InputValueTextBoxConfigState("Special Action", InputConfigState.Position.RightColumn, 7, InputValueTextBoxConfigState.Mode.DisableOnInput, InputControl.ControlType.BooleanValue));
        }
    }
}
