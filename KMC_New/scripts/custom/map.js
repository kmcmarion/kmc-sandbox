mapboxgl.accessToken = 'pk.eyJ1IjoiY2Fyb2xkZXN0cmV6YSIsImEiOiJjanp3OGo4cHEwbmduM2hwZnNuZDJzZWxyIn0.rF-a4FSzqc5PhileOuq7jg';

var map = new mapboxgl.Map({
    container: 'map',
    style: 'mapbox://styles/mapbox/light-v10',
    center: [121.046001, 14.549944],
    zoom: 18
});

var branches = {
    "type": "FeatureCollection",
    "features": [
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.05428,
                    14.5561
                ]
            },
            "properties": {
                "buildingName": "Uptown Place Tower 2",
                "phone": "(02) 8779 6541",
                "address": "19th & 20th Floor, Uptown Place Tower 2, 11th Ave Uptown, Taguig, Metro Manila",
                "city": "BGC",
                "link": "/bgc-taguig-office-space/uptown-place-tower-2/",
                "coords": [121.049569, 14.545188]
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.04301,
                    14.53518
                ]
            },
            "properties": {
                "buildingName": "Cyber Sigma",
                "phone": "(02) 8779 6540",
                "address": "19th & 20th Floor, Robinson's Cyber Sigma, Lawton Ave, Taguig, 1630 Metro Manila",
                "city": "BGC",
                "link": "/bgc-taguig-office-space/cyber-sigma/",
                "coords": [121.049569, 14.545188]
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.05292,
                    14.54511
                ]
            },
            "properties": {
                "buildingName": "SM Aura Office Tower",
                "phone": "(02) 8779 6540",
                "address": "11th Floor, SM Aura Business Tower,, 26th St., McKinley Parkway, Bonifacio Global City,, Taguig, Metro Manila",
                "city": "BGC",
                "link": "/bgc-taguig-office-space/sm-aura-office-tower/",
                "coords": [121.049569, 14.545188]
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.04597,
                    14.54993
                ]
            },
            "properties": {
                "buildingName": "Picadilly Star",
                "phone": "(02) 8779 6540",
                "address": "25th Floor, Picadilly Star Building, 4th Avenue, corner 27th Street, Bonifacio Global City, Taguig, 1634 Metro Manila",
                "city": "BGC",
                "link": "/bgc-taguig-office-space/picadilly-star/",
                "coords": [121.049569, 14.545188]
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.04621,
                    14.54786
                ]
            },
            "properties": {
                "buildingName": "Sun Life Centre",
                "phone": "(02) 8779 6540",
                "address": "8th Floor, Sun Life Centre Building, 5th Avenue, Bonifacio Global City, Taguig, 1634 Metro Manila",
                "city": "BGC",
                "link": "/bgc-taguig-office-space/sun-life-centre/",
                "coords": [121.049569, 14.545188]
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.04704,
                    14.55296
                ]
            },
            "properties": {
                "buildingName": "Four/NEO",
                "phone": "(02) 8779 6540",
                "address": "4th Ave, Taguig, 1630 Metro Manila",
                "city": "BGC",
                "link": "/bgc-taguig-office-space/four-neo/",
                "coords": [121.049569, 14.545188]

            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.05122,
                    14.55243
                ]
            },
            "properties": {
                "buildingName": "Ore Central",
                "phone": "(02) 8779 6540",
                "address": "11th and 12th Floors, ORE Central, 31st Street, Taguig, 1634 Metro Manila",
                "city": "BGC",
                "link": "/bgc-taguig-office-space/ore-central/",
                "coords": [121.049569, 14.545188]
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.02477,
                    14.56033
                ]
            },
            "properties": {
                "buildingName": "V Corporate Centre",
                "phone": "(02) 8779 6540",
                "address": "5th & 9th Floor, V Corporate Centre,, L.P. Leviste Street, Salcedo Village,, Makati, 1227 Metro Manila",
                "city": "Makati",
                "link": "/makati-office-space/v-corporate-centre/",
                "coords": [121.025867, 14.557385],

            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.02351,
                    14.5609
                ]
            },
            "properties": {
                "buildingName": "Frabelle Corporate Plaza",
                "phone": "(02) 8779 6540",
                "address": "18th Floor, Frabelle Corporate Plaza, 129, Bautista, Makati, 1227 Metro Manila",
                "city": "Makati",
                "link": "/makati-office-space/frabelle-corporate-plaza/",
                "coords": [121.025867, 14.557385],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.01823,
                    14.55803

                ]
            },
            "properties": {
                "buildingName": "Rufino Pacific Tower",
                "phone": "(02) 8779 6540",
                "address": "14-B & 29th Floor, Rufino Pacific Tower, 6784 Ayala Ave, Legazpi Village, Makati, 1200 Metro Manila",
                "city": "Makati",
                "link": "/makati-office-space/rufino-pacific-tower/",
                "coords": [121.025867, 14.557385],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.021331,
                    14.561131

                ]
            },
            "properties": {
                "buildingName": "Armstrong Corporate Center",
                "phone": "(02) 8779 6540",
                "address": "Salcedo, Village, Makati, 1227 Metro Manila",
                "city": "Makati",
                "link": "/makati-office-space/armstrong-corporate-center/",
                "coords": [121.021331, 14.561131],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.06776,
                    14.5897
                ]
            },
            "properties": {
                "buildingName": "Rockwell Business Center Tower 1",
                "phone": "(02) 8779 6540",
                "address": "5th Floor & 6th Floor, Rockwell Business Center Tower 1, Ortigas Avenue, Pasig City, Pasig, 1604 Metro Manila",
                "city": "Ortigas",
                "link": "/ortigas-office-space/rockwell-business-center-tower-1/",
                "coords": [121.059914, 14.584400],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.06068,
                    14.58718
                ]
            },
            "properties": {
                "buildingName": "Robinsons Cyberscape Gamma",
                "phone": "(02) 8779 6540",
                "address": "15th Floor, Robinsons Cyberscape Gamma, Topaz &, Ruby Rd, Ortigas Center, Ortigas, 1600 Metro Manila",
                "city": "Ortigas",
                "link": "/ortigas-office-space/robinsons-cyberscape-gamma/",
                "coords": [121.059914, 14.584400],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.06834,
                    14.58969
                ]
            },
            "properties": {
                "buildingName": "Rockwell Business Center Tower 3",
                "phone": "(02) 8779 6540",
                "address": "8th Floor Rockwell Business Center Tower 3, Ortigas Ave, Pasig, 1604 Metro Manila",
                "city": "Ortigas",
                "link": "/ortigas-office-space/rockwell-business-center-tower-3/",
                "coords": [121.059914, 14.584400],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.05951,
                    14.586251
                ]
            },
            "properties": {
                "buildingName": "Podium West Tower",
                "phone": "(02) 8779 6540",
                "address": "26th and 27th Floors, The Podium, Lower, Ortigas Center, Pasig City",
                "city": "Mandaluyong",
                "link": "/mandaluyong-office-space/podium-west-tower/",
                "coords": [121.05951, 14.586251],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.05517,
                    14.57635
                ]
            },
            "properties": {
                "buildingName": "Rockwell Sheridan 1",
                "phone": "(02) 8779 6540",
                "address": "10th Floor, Rockwell Business Center Sheridan Tower 1, Sheridan & United Street, Mandaluyong, 1554 Metro Manila",
                "city": "Mandaluyong",
                "link": "/mandaluyong-office-space/rockwell-sheridan-1/",
                "coords": [121.042840, 14.583199],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.08142,
                    14.591
                ]
            },
            "properties": {
                "buildingName": "Robinsons Zeta Tower",
                "phone": "(02) 8779 6540",
                "address": "7th Floor, Robinsons Zeta Tower, C5 Road, Quezon City, 1800 Metro Manila",
                "city": "Quezon City",
                "link": "/quezon-city-office-space/robinsons-zeta-tower",
                "coords": [121.069200, 14.608199],

            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    121.03659,
                    14.41881
                ]
            },
            "properties": {
                "buildingName": "One Griffinstone",
                "phone": "(02) 8779 6540",
                "address": "Alabang, Muntinlupa, Metro Manila",
                "city": "Alabang",
                "link": "/alabang-office-space/one-griffinstone/",
                "coords": [121.043858, 14.417280],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    120.98257,
                    14.54064
                ]
            },
            "properties": {
                "buildingName": "Five E-Com Center",
                "phone": "(02) 8779 6540",
                "address": "Block 22 Harbor Drive corner BayShore, Mall of Asia Complex, Pasay",
                "city": "Pasay",
                "link": "#",
                "coords": [120.982567, 14.540639],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    123.90637,
                    10.33018
                ]
            },
            "properties": {
                "buildingName": "Skyrise 4 Cebu IT Park",
                "phone": "(02) 8779 6540",
                "address": "18th Floor, W Geonzon St, Cebu City, Cebu",
                "city": "Cebu",
                "link": "/cebu-office-space/skyrise-4/",
                "coords": [123.906996, 10.321501],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    123.90637,
                    10.33015
                ]
            },
            "properties": {
                "buildingName": "Skyrise 4B Cebu IT Park",
                "phone": "(02) 8779 6540",
                "address": "16th and 17th Floors, W Geonzon St, Cebu City, 6000 Cebu",
                "city": "Cebu",
                "link": "/cebu-office-space/skyrise-4b/",
                "coords": [123.906996, 10.321501],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    122.5462,
                    10.71714

                ]
            },
            "properties": {
                "buildingName": "Festive Walk Office Tower",
                "phone": "(02) 8779 6540",
                "address": "Festive Walk Office Tower, 1 Megaworld Blvd, Mandurriao, Iloilo City, 5000 Iloilo",
                "city": "Iloilo",
                "link": "/iloilo-office-space/festive-walk-tower/",
                "coords": [122.552041, 10.716597],
            }
        },
        {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    120.573504,
                    15.178493

                ]
            },
            "properties": {
                "buildingName": "One West Aeropark",
                "phone": "(02) 8779 6540",
                "address": "Industrial Estate - 5, Clark Global City, Clark Freeport Zone, Mabalacat, 2023 Pampanga",
                "city": "Clark",
                "link": "/clark-office-space/one-west-aeropark/",
                "coords": [120.573504, 15.178493]
            }
        }


    ]
}

map.on('load', function (e) {
    map.addSource('places', {
        type: 'geojson',
        data: branches
    });
    buildLocationList(branches);
    branches.features.forEach(marker => {
        var el = document.createElement('div');
        el.className = 'marker';
        new mapboxgl.Marker(el, { offset: [0, -23] })
            .setLngLat(marker.geometry.coordinates)
            .addTo(map);
        el.addEventListener('click', function (e) {
            flyToStore(marker);
            createPopUp(marker);
            e.stopPropagation();
        });
    });
});


function buildLocationList(data) {
    var cityList = [];
    for (c = 0; c < data.features.length; c++) {
        if (cityList.map((e) => {
            return e.city;
        }).indexOf(data.features[c].properties.city) === -1) {
            var obj = {};
            obj["city"] = data.features[c].properties.city;
            obj["coord"] = data.features[c].properties.coords;
            cityList.push(obj);
        }
    }
    // Dynamic listing container 
    var listings = document.getElementById('listings');
    for (e = 0; e < cityList.length; e++) {
        var cities = listings.appendChild(document.createElement('div'));
        cities.className = 'cities';
        header = cities.appendChild(document.createElement('h4'));
        header.className = 'text-orange';
        header.innerHTML = cityList[e].city;
        header.setAttribute("data-toggle", "collapse");
        var cityListId = cityList[e].city.replace(/ +/g, "");
        header.setAttribute("data-target", "#city-" + cityListId);
        collapseContainer = cities.appendChild(document.createElement('div'));
        collapseContainer.className = 'collapse';
        collapseContainer.id = 'city-' + cityListId;
        cities.appendChild(document.createElement('hr'));
        header.style = 'color: #fff;';

        // Add this EventListener for the cities
        header.addEventListener('click', (e) => {
            displayedCity = listings.getElementsByClassName("show");
            if (displayedCity.length >= 1) {
                document.getElementById(displayedCity[0].id).setAttribute("class", "collapse");
            }
            var clickedCity = e.srcElement.innerHTML;
            cityIndex = cityList.map((e) => {
                return e.city;
            }).indexOf(clickedCity);
            featuredCity = cityList[cityIndex];
            flyToCity(featuredCity);
        });
    }
    var mapLink;
    for (i = 0; i < data.features.length; i++) {
        var currentFeature = data.features[i]
        var prop = currentFeature.properties;
        var cityId = prop.city.replace(/ +/g, "");
        var cityContainer = document.getElementById('city-' + cityId);
        var building = cityContainer.appendChild(document.createElement('div'));
        //building.style = 'padding-left: 20px;';
        mapLink = building.appendChild(document.createElement('a'));
        mapLink.href = 'javascript:';
        mapLink.style = 'color: #fff; cursor:pointer;';
        mapLink.className = 'title building-link';
        mapLink.dataPosition = i;
        mapLink.innerHTML = prop.buildingName;
        var details = mapLink.appendChild(document.createElement('div'));
        details.className = "listing-details";
        //details.appendChild(document.createElement('hr'));
        mapLink.addEventListener('click', (e) => {
            var clickedListing = data.features[e.srcElement.dataPosition];
            flyToStore(clickedListing);
            createPopUp(clickedListing);
        });
    }
}

function flyToCity(currentCity) {
    map.flyTo({
        center: currentCity.coord,
        zoom: 13
    });
}

function flyToStore(currentFeature) {
    map.flyTo({
        center: currentFeature.geometry.coordinates,
        zoom: 15
    });
}

function createPopUp(currentFeature) {
    var popUps = document.getElementsByClassName('mapboxgl-popup');
    if (popUps[0]) popUps[0].remove();
    var popUp = new mapboxgl.Popup({ closeOnClick: false })
        .setLngLat(currentFeature.geometry.coordinates)
        .setHTML('<h3 style="color: #000;">' + '<a href="' + currentFeature.properties.link + '">' + currentFeature.properties.buildingName + '</a></h3>'
            +
            '<p style="color: #000">' + currentFeature.properties.address + '</p>' +
            '<a href="tel:' + currentFeature.properties.phone + '">' + currentFeature.properties.phone + '</a>')
        .addTo(map);
}