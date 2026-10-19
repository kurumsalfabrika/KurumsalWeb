let selectedTemplate = '';

function selectTemplate(template) {
    localStorage.setItem('selectedTemplate', template);
    window.location.href = 'fiyataldesign/design.html';
}

window.onload = function () {
    if (window.location.pathname.endsWith('design.html')) {
        selectedTemplate = localStorage.getItem('selectedTemplate');
        const canvas = new fabric.Canvas('canvas');

        // Ekran boyutlarýný kontrol et
        let canvasWidth = window.innerWidth <= 760 ? 480 : 800;
        let canvasHeight = window.innerWidth <= 760 ? 350 : 600;

        if (selectedTemplate) {
            const proxyUrl = `https://www.sodemcanta.com.tr/api/proxy/image?url=${encodeURIComponent(selectedTemplate)}`;
            fabric.Image.fromURL(proxyUrl, function (img) {
                img.set({
                    crossOrigin: 'Anonymous', // CORS ayarý
                    selectable: false,
                    evented: false,
                    left: 0,
                    top: 0,
                });

                img.scaleToWidth(canvasWidth);
                img.scaleToHeight(canvasHeight);
                canvas.setBackgroundImage(img);
                canvas.setWidth(canvasWidth);
                canvas.setHeight(canvasHeight);

                canvas.renderAll();
            }, { crossOrigin: 'Anonymous' });
        }

        window.addText = function () {
            const textInput = document.getElementById('textInput').value;
            const text = new fabric.Text(textInput, {
                left: 50,
                top: 50,
                fontSize: 20,
                fill: 'black'
            });
            canvas.add(text);
        };

        window.addImage = function () {
            const fileInput = document.getElementById('fileInput').files[0];
            const reader = new FileReader();
            reader.onload = function (e) {
                const imgElement = new Image();
                imgElement.crossOrigin = 'crossOrigin', 'Anonymous'; // CORS ayarý
                imgElement.src = e.target.result;
                imgElement.onload = function () {
                    const imgInstance = new fabric.Image(imgElement);
                    imgInstance.set({ left: 50, top: 100, angle: 0, padding: 10, cornersize: 10 });
                    canvas.add(imgInstance);
                };
            };
            reader.readAsDataURL(fileInput);
        };


        window.saveDesignAsJPG = function () {
            const dataURL = canvas.toDataURL('image/jpeg', 0.8);

            // Download the image locally


            // Convert dataURL to Blob
            function dataURLtoBlob(dataURL) {
                const byteString = atob(dataURL.split(',')[1]);
                const mimeString = dataURL.split(',')[0].split(':')[1].split(';')[0];
                const ab = new ArrayBuffer(byteString.length);
                const ia = new Uint8Array(ab);
                for (let i = 0; i < byteString.length; i++) {
                    ia[i] = byteString.charCodeAt(i);
                }
                return new Blob([ab], { type: mimeString });
            }

            const blob = dataURLtoBlob(dataURL);

            // Upload the image to the server
            const formData = new FormData();
            formData.append("image", blob, "design.jpg");

            $.ajax({
                url: '/api/design/upload',
                type: 'POST',
                data: formData,
                processData: false,
                contentType: false,
                success: function (response) {

                    const uploadedImageUrl = response.url;
                    window.location.href = `/FiyatAl/BilgiGonder?imageUrl=${encodeURIComponent(uploadedImageUrl)}`;

           
                },
                error: function (xhr, status, error) {
                    alert('Error: ' + error);
                }
            });
        };


        window.downloadDesignAsJPG = function () {
            const dataURL = canvas.toDataURL({
                format: 'jpeg',
                quality: 0.8
            });
            const link = document.createElement('a');
            link.href = dataURL;
            link.download = 'design.jpg';
            link.click();
        };

        window.deleteSelected = function () {
            const activeObject = canvas.getActiveObject();
            if (activeObject) {
                canvas.remove(activeObject);
            }
        };

        document.addEventListener('keydown', function (event) {
            if (event.key === 'Delete' || event.key === 'Backspace') {
                deleteSelected();
            }
        });
    }
};
