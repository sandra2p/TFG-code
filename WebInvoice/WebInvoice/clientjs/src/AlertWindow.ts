async function openWindow(formContext: Xrm.Mov_line) {

    const execute_mov_TestApi_Request = {
        // Parameters
        mov_Field_Name: "mov_total", // Edm.String
        mov_TargetEntity_Name: "mov_line", // Edm.String
        mov_TargetEntityId: formContext.data.entity.getId().replace(/\{|\}/g,''), // Edm.String

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

    const apiResponse : TestApi = await Xrm.WebApi.online.execute(execute_mov_TestApi_Request)
    .then((response : Response) => response.json());
    const msg = `Price: ${apiResponse.mov_testapi_price} * Quantity: ${apiResponse.mov_testapi_quantity} = Total: ${apiResponse.mov_testapi_total}`;
    const alertStrings = { confirmButtonLabel: "Yes", text: msg, title: "Sample title" };
    const alertOptions = { height: 120, width: 260 };
    Xrm.Navigation.openAlertDialog(alertStrings, alertOptions).then(
        function(success) {
            console.log("Alert dialog closed");
        }, 
        function(error) {
            console.log(error.message);
        }
    );
}