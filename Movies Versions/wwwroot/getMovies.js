function getMatrixMovie() {
    var version = $("#matrixSelect").val();

    $.ajax({
        type: "GET",
        url: "/api/query/matrixmovie?api-version-query=" + version,

        success: function (data, textStatus, request) {
            success(data, textStatus, request, version);
        }
    });
}

function getTheHungerGamesMovie() {
    var version = $("#theHungerGamesSelect").val();

    $.ajax({
        type: "GET",
        url: "/api/header/TheHungerGames",
        beforeSend: function (request) {
            request.setRequestHeader("api-version-header", version);
        },
        success: function (data, textStatus, request) {
            success(data, textStatus, request, version);
        }
    });
}

function getSpiderManMovie() {
    var version = $("#spidermanSelect").val();

    $.ajax({
        type: "GET",
        url: "/api/deprecating/spidermanmovie",
        beforeSend: function (request) {
            request.setRequestHeader("Content-Type", "text/plain;api-version-mediatype=" + version);
        },
        success: function (data, textStatus, request) {
            success(data, textStatus, request, version);
        }
    });
}

function getTransformersMovie() {
    var version = $("#transformersSelect").val();

    $.ajax({
        type: "GET",
        url: "/api/path/TransformersMovie/" + version,
        success: function (data, textStatus, request) {
            success(data, textStatus, request, version);
        }
    });
}

function getStarWarsMovie() {

    $.ajax({
        type: "GET",
        url: "/api/default/starwarsmovie",
        success: function (data, textStatus, request) {
            success(data, textStatus, request);
        }
    });
}

function getfindingNemoMovie() {
    var version = $("#findingNemoSelect").val();

    $.ajax({
        type: "GET",
        url: "/api/map/FindingNemo/",
        beforeSend: function (request) {
            request.setRequestHeader("api-version-custom-header", version);
        },
        success: function (data, textStatus, request) {
            success(data, textStatus, request, version);
        }
    });
}




function success(data, textStatus, request, version) {
    var deprecatedVersions = request.getResponseHeader('api-deprecated-versions');
    if (deprecatedVersions != undefined) {
        var res = deprecatedVersions.split(", ");
        if (res.includes(version)) {
            alert("[Deprecate] " + data);
        }
        else {
            alert(data);
        }
    }
    else {
        alert(data);
    }
}