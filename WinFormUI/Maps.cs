﻿using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.Web.WebView2.WinForms; // Pastikan Anda menambahkan referensi ini

namespace AddProdukdanSampah
{
    public partial class Maps : Form
    {
        private WebView2 webView;

        public Maps()
        {
            InitializeComponent();
            InitializeWebView(); // Inisialisasi WebView
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
            return @"<!DOCTYPE html>
<html>
<head>
    <title>Google Maps Example</title>
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <script src='https://maps.googleapis.com/maps/api/js?key=AIzaSyBZoqwrp95PDYEgr1rR5QVyNS9iZa_76C0&libraries=places&callback=initMap' async defer></script>
    <style>
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }
        #map {
            height: 100%;
            width: 100%;
        }
        #searchBox {
            position: absolute;
            top: 10px;
            left: 10px;
            width: 300px;
            padding: 10px;
            z-index: 2; /* ensure visibility on the top */
            background: white;
            border: 1px solid #ccc;
            border-radius: 5px; /* Corner rounding */
            box-shadow: 0 2px 5px rgba(0,0,0,0.3); /* Optional shadow for better visibility */
        }
    </style>
</head>
<body>
    <input id='searchBox' type='text' placeholder='Enter a location'>
    <div id='map'></div>
    <script>
        let map;
        let marker;

        function initMap() {
            // Cek apakah dukungan geolocation ada
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function(position) {
                    const userLocation = {
                        lat: position.coords.latitude,
                        lng: position.coords.longitude
                    };

                    // Inisialisasi peta di lokasi pengguna
                    map = new google.maps.Map(document.getElementById('map'), {
                        center: userLocation,
                        zoom: 13,
                        mapTypeId: 'roadmap' // Default to road map
                    });

                    marker = new google.maps.Marker({
                        position: userLocation,
                        map: map,
                        draggable: true // marker bisa dipindah-pindah
                    });

                    const searchBox = new google.maps.places.SearchBox(
                        document.getElementById('searchBox')
                    );

                    map.addListener('bounds_changed', function() {
                        searchBox.setBounds(map.getBounds());
                    });

                    searchBox.addListener('places_changed', function() {
                        const places = searchBox.getPlaces();
                        
                        if (places.length === 0) {
                            return;
                        }

                        const place = places[0];

                        if (!place.geometry) {
                            console.log('Returned place contains no geometry');
                            return;
                        }

                        // Set posisi marker dan center map pada tempat yang dicari
                        marker.setPosition(place.geometry.location);
                        map.setCenter(place.geometry.location);
                    });

                }, function() {
                    // Jika pengguna tidak memberikan izin untuk akses lokasi
                    handleLocationError(true, map.getCenter());
                });
            } else {
                // Browser tidak mendukung Geolocation
                handleLocationError(false, map.getCenter());
            }
        }

        function handleLocationError(browserHasGeolocation, pos) {
            const infoWindow = new google.maps.InfoWindow();
            infoWindow.setPosition(pos);
            infoWindow.setContent(browserHasGeolocation ?
                'Error: The Geolocation service failed.' :
                'Error: Your browser doesn\'t support geolocation.');
            infoWindow.open(map);
        }
    </script>
</body>
</html>";
        }
    }


}
