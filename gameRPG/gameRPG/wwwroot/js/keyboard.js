Import System.Runtime.InteropServices

' In SDK-style projects such as this one, several assembly attributes that were historically
' defined in this file are now automatically added during build and populated with
' values defined in project properties. For details of which attributes are included
' and how to customise this process see: https://aka.ms/assembly-info-properties


' Setting ComVisible to false makes the types in this assembly not visible to COM
' components.  If you need to access a type in this assembly from COM, set the ComVisible
' attribute to true on that type.

<Assembly: ComVisible(False)> 

' The following GUID is for the ID of the typelib if this project is exposed to COM.

<Assembly: Guid("04c3d4dc-ea58-4873-a216-a9d1c1eb4885")> 
    window.addKeyDownEventListener = (dotNetHelper) => {
        document.addEventListener('keydown', (event) => {
            switch (event.key) {
                case 'ArrowUp':
                    dotNetHelper.invokeMethodAsync('MoveCharacter', 'up');
                    break;
                case 'ArrowDown':
                    dotNetHelper.invokeMethodAsync('MoveCharacter', 'down');
                    break;
                case 'ArrowLeft':
                    dotNetHelper.invokeMethodAsync('MoveCharacter', 'left');
                    break;
                case 'ArrowRight':
                    dotNetHelper.invokeMethodAsync('MoveCharacter', 'right');
                    break;
            }
        });
    };
