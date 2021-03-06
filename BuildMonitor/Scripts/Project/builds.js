﻿$(document).ready(function () {
	$('body').css('display', 'none');
	$('body').fadeIn(1000);

	setInterval(function () {
		$.ajax({
			url: '/Home/GetBuilds',
			cache: false,
			success: function (data) {
				$.each(data.Builds, function (i, build) {
					var divId = "#BuildDiv-" + build.Id;
					var buildDiv = $(divId);
					buildDiv.replaceWith(build.Content);
				});

				$("#last-updated").text(data.UpdatedText).removeClass("update-failure");
			},
			error: function (xhr, textStatus, errorThrown) {
				displayAjaxError(xhr, textStatus, errorThrown);
			}
		});
	}, 15000);
});