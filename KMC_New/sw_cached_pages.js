const cacheName = 'kmc_cached_assets';
const cacheAssets = [
    '/css/RTE.css',
    '/css/main.min.css',
    '/css/fontawesome-free-5.12.0-web/css/all.min.css',
    '/OwlCarousel2-2.3.4/dist/assets/owl.carousel.min.css',
    '/OwlCarousel2-2.3.4/dist/assets/owl.theme.default.min.css',
    '/css/hubspot-form.css',
    '/OwlCarousel2-2.3.4/dist/owl.carousel.min.js',
    '/Scripts/custom/external-scripts.es5.min.js',
    '/Scripts/custom/commonOwlCarousel.es5.min.js',
    '/Scripts/custom/custom_scripts.es5.min.js'
];

//Call Install Event
self.addEventListener('install', e => {
    console.log('Service Worker: Installed');

    e.waitUntil(
        caches
            .open(cacheName)
            .then(cache => {
                console.log('Service Worker: Caching Files');
                cache.addAll(cacheAssets);
            })
        .then(()=>self.skipWaiting())
    );
});

//Call Activate Event
self.addEventListener('activate', (e) => {
    console.log('Service Worker: Activated');
    //Remove unwanted caches
    e.waitUntil(
        caches.keys().then(cacheNames => {
            return Promise.all(
                cacheNames.map(cache => {
                    if (cache !== cacheName) {
                        console.log('Service Worker: Clearing Old Cache');
                        return caches.delete(cache);
                    }
                })
            )
        })
    );
});

//Call Fetch Event
self.addEventListener('fetch', e => {
    console.log('Service Worker: Fetching');
    e.respondWith(
        fetch(e.request).catch(() => caches.match(e.request))
    );
});

