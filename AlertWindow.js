async function openWindow(primaryControl) {
    var formContext = primaryControl;

    var execute_mov_TestApi_Request = {
        // Parameters
        mov_Field_Name: "mov_total", // Edm.String
        mov_TargetEntity_Name: "mov_line", // Edm.String
        mov_TargetEntityId: formContext.data.entity._entityId.guid, // Edm.String

        getMetadata: function() {
            return {
                boundParameter: null,
                parameterTypes: {
                    mov_Field_Name: { typeName: "Edm.String", structuralProperty: 1 },
                    mov_TargetEntity_Name: { typeName: "Edm.String", structuralProperty: 1 },
                    mov_TargetEntityId: { typeName: "Edm.String", structuralProperty: 1 }
                },
                operationType: 0,
                operationName: "mov_TestApi"
            };
        }
    };

    const json = await Xrm.WebApi.online.execute(execute_mov_TestApi_Request).then(
        function success(response) {
            if (response.ok) {
                console.log(response);
                return response.json();
            }
        }
    ).then(function(responseBody) {
        var result = responseBody;
        console.log(result);
        return result;
    }).catch(function(error) {
        console.log(error);
    });

    var alertStrings = { confirmButtonLabel: "Yes", text: JSON.stringify(json), title: "Sample title" };
    var alertOptions = { height: 120, width: 260 };
    Xrm.Navigation.openAlertDialog(alertStrings, alertOptions).then(
        function(success) {
            console.log("Alert dialog closed");
        },
        function(error) {
            console.log(error.message);
        }
    );
}