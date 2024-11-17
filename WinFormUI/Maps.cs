using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.Web.WebView2.WinForms; // Pastikan Anda menambahkan referensi ini
using DotNetEnv;

namespace AddProdukdanSampah
{
    public partial class Maps : Form
    {
        private WebView2 webView;

        public Maps()
        {
            InitializeComponent();
            InitializeWebView(); // Inisialisasi WebView
            Env.Load();
            LoadMap();
        }

        private void InitializeWebView()
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill // Menetapkan ukuran untuk memenuhi form
            };
            this.Controls.Add(webView);
        }

        private void LoadMap()
        {
            try
            {
                string resourcesPath = Path.Combine(Application.StartupPath, "Resources");
                if (!Directory.Exists(resourcesPath))
                {
                    Directory.CreateDirectory(resourcesPath);
                }

                string htmlFilePath = Path.Combine(resourcesPath, "Map.html");
                File.WriteAllText(htmlFilePath, GetMapHtmlContent());

                webView.Source = new Uri(htmlFilePath); // Navigasi ke halaman HTML
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading map: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetMapHtmlContent()
        {
            string apiKey = Env.GetString("GOOGLE_MAPS_API_KEY");
            return $@"<!DOCTYPE html>
<html>
<head>
    <title>Google Maps Example</title>
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <script src='https://maps.googleapis.com/maps/api/js?key={apiKey}&libraries=places&callback=initMap' async defer></script>
    <style>
        html, body {{
            height: 100%;
            margin: 0;
            padding: 0;
        }}
        #map {{
            height: 100%;
            width: 100%;
        }}
        #searchBox {{
            position: absolute;
            top: 10px;
            left: 10px;
            width: 300px;
            padding: 10px;
            z-index: 2;
            background: white;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.3);
        }}
    </style>
</head>
<body>
    <input id='searchBox' type='text' placeholder='Enter a location'>
    <div id='map'></div>
    <script>
        let map;
        let marker;

        function initMap() {{
            if (navigator.geolocation) {{
                navigator.geolocation.getCurrentPosition(function(position) {{
                    const userLocation = {{
                        lat: position.coords.latitude,
                        lng: position.coords.longitude
                    }};

                    map = new google.maps.Map(document.getElementById('map'), {{
                        center: userLocation,
                        zoom: 13,
                        mapTypeId: 'roadmap'
                    }});

                    marker = new google.maps.Marker({{
                        position: userLocation,
                        map: map,
                        draggable: true
                    }});

                    const searchBox = new google.maps.places.SearchBox(
                        document.getElementById('searchBox')
                    );

                    map.addListener('bounds_changed', function() {{
                        searchBox.setBounds(map.getBounds());
                    }});

                    searchBox.addListener('places_changed', function() {{
                        const places = searchBox.getPlaces();
                        
                        if (places.length === 0) {{
                            return;
                        }}

                        const place = places[0];

                        if (!place.geometry) {{
                            console.log('Returned place contains no geometry');
                            return;
                        }}

                        marker.setPosition(place.geometry.location);
                        map.setCenter(place.geometry.location);
                    }});

                }}, function() {{
                    handleLocationError(true, map.getCenter());
                }});
            }} else {{
                handleLocationError(false, map.getCenter());
            }}
        }}

        function handleLocationError(browserHasGeolocation, pos) {{
            const infoWindow = new google.maps.InfoWindow();
            infoWindow.setPosition(pos);
            infoWindow.setContent(browserHasGeolocation ?
                'Error: The Geolocation service failed.' :
                'Error: Your browser doesn\'t support geolocation.');
            infoWindow.open(map);
        }}
    </script>
</body>
</html>";
        }

    }


}

