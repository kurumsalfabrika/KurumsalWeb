(function ($) {
    $.fn.mapmarker = function (options) {
        var opts = $.extend({}, $.fn.mapmarker.defaults, options);

        return this.each(function () {
            // Apply plugin functionality to each element
            var map_element = this;
            addMapMarker(map_element, opts.zoom, opts.center, opts.markers);
        });
    };

    // Set up default values
    var defaultMarkers = {
        "markers": []
    };

    $.fn.mapmarker.defaults = {
        zoom: 8,
        center: { lat: 41.0082, lng: 28.9784 }, // Default to San Francisco, USA
        markers: defaultMarkers
    };

    // Main function code here (ref:google map api v3)
    function addMapMarker(map_element, zoom, center, markers) {
        // Set center of the Map
        var myOptions = {
            zoom: zoom,
            center: center,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var map = new google.maps.Map(map_element, myOptions);

        // Run the marker JSON loop here
        $.each(markers.markers, function (i, the_marker) {
            var latitude = parseFloat(the_marker.latitude);
            var longitude = parseFloat(the_marker.longitude);
            var icon = the_marker.icon;
            var baloon_text = the_marker.baloon_text;

            if (latitude && longitude) {
                var marker = new google.maps.Marker({
                    map: map,
                    position: new google.maps.LatLng(latitude, longitude),
                    animation: google.maps.Animation.DROP,
                    icon: icon
                });

                // Set up markers with info windows 
                google.maps.event.addListener(marker, 'click', function () {
                    // Close all open infowindows
                    if (infowindow) {
                        infowindow.close();
                    }

                    var infowindow = new google.maps.InfoWindow({
                        content: baloon_text
                    });

                    infowindow.open(map, marker);
                });
            }
        });
    }
})(jQuery);