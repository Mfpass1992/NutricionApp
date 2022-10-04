<script type="text/javascript">

function getUnit(id) {
    for (var i in assetStatusEnum) {
        if (id == assetStatusEnum[i]) {     
            return i;
        }
    }
}
   
var assetStatusEnum = @(Html.EnumToString<Units>());
    console.log(assetStatusEnum);

    $(".selectionItems").click(function() {
        CallController((this));
});

        function CallController(el) {
            $.ajax({
                type: "GET",
                url: "/ProductInfo/GetProductInformation",
                data: { "productId": el.dataset.productid },
                dataType: "json",
                success: function (data) {
                    console.log(data);
                    var Nutritions = data.nutrition;
                    console.log(Nutritions);
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    console.log("erro");
                },
                complete: function (data) {
                    var response = data.responseJSON;
                    $("#productContainer").prepend("<h1>" + response.name + "<h1>");
                    $(".nutrient_th").append("Nutrient");
                    $(".percentDaily_th").append("Percent of daily recommended intake");
                    $(".weight_th").append(response.amount + getUnit(response.unit));
                    for (var el in response.nutrition) {
                        var nutri = response.nutrition[el];
                        $("#table_body").append("<tr>");
                        $("#table_body").append("<td class=nutri-label>" + nutri.name + "</td>");
                        $("#table_body").append("<td>" + nutri.amount + getUnit(nutri.unit) + "</td>");
                        $("#table_body").append("<td>" + nutri.percentOfDailyNeeds + "</td>");
                        $("#table_body").append("</tr>");
                    }
                }
            });
};

</script>