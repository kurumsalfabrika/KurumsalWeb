var myMarkers = {
    "markers": [
        { "latitude": "39.72212720551878", "longitude": "37.01007046979471", "icon": "https://www.sodemcanta.com.tr/img/map-marker2.png", "baloon_text": "Sodem Canta" }
    ]
};

$("#map").mapmarker({
    zoom: 14,
    center: { lat: 39.72212720551878, lng: 37.01007046979471 },
    markers: myMarkers
});