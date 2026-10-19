function svgturkiyeharitasi() {
    const element = document.querySelector('#svg-turkiye-haritasi');
    const info = document.querySelector('.il-isimleri');

    element.addEventListener(
        'mouseover',
        function (event) {
            if (event.target.tagName === 'path' && event.target.parentNode.id !== 'guney-kibris') {
                info.innerHTML = [
                    '<div>',
                    event.target.parentNode.getAttribute('data-iladi'),
                    '</div>'
                ].join('');
            }
        }
    );

    element.addEventListener(
        'mousemove',
        function (event) {
            info.style.top = event.pageY + 25 + 'px';
            info.style.left = event.pageX + 'px';
        }
    );

    element.addEventListener(
        'mouseout',
        function (event) {
            info.innerHTML = '';
        }
    );

    element.addEventListener(
        'click',
        function (event) {
            if (event.target.tagName === 'path') {
                const parent = event.target.parentNode;
                const id = parent.getAttribute('id');

                if (id === 'guney-kibris') {
                    return;
                }

                window.location.href = (
                    '#'
                    + id
                    + '-'
                    + parent.getAttribute('data-plakakodu')
                );
            }
        }
    );

    const renkliIller = {
        'kayseri': '#f1c40f',
        'nigde': '#f1c40f',
        'nevsehir': '#f1c40f',
        'kirsehir': '#f1c40f',
        'yozgat': '#f1c40f',
        'tokat': '#f1c40f',
        'aksaray': '#f1c40f',
        'erzincan': '#f1c40f',
        'sivas': '#f1c40f',
        'corum': '#f1c40f',
        'kahramanmaras': '#f1c40f',
        'malatya': '#f1c40f'
    };

    Object.entries(renkliIller).forEach(([ilId, renk]) => {
        const il = document.querySelector(`#${ilId} path`);
        if (il) {
            il.style.fill = renk;

            il.addEventListener('mouseenter', () => {
                il.dataset.originalColor = il.style.fill;
                il.style.fill = '#e67e22'; // Hover rengi
            });

            il.addEventListener('mouseleave', () => {
                il.style.fill = il.dataset.originalColor;
            });
        }
    });

}
