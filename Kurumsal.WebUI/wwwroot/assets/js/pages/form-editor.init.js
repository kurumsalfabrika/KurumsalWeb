$(document).ready(function () {
    tinymce.init(
        {
            selector: "textarea#elm1,textarea#elm2",
            language: 'tr_TR',
            language_url: '/assets/js/tr_TR.js',
            height: 300,

            image_caption: true,
            autosave_interval: '30s',
            image_title: true,
            paste_data_images: true,
            automatic_uploads: true,
            images_upload_url: '/Image/Upload',
            images_upload_base_path: '',
            file_picker_types: 'image',
            forced_root_block: '', 
            entity_encoding: 'raw',
            file_picker_callback: function (cb, value, meta) {

                var input = document.createElement('input');
                input.setAttribute('type', 'file');
                input.setAttribute('accept', 'image/*');

                input.onchange = function () {
                    var file = this.files[0];

                    var reader = new FileReader();
                    reader.readAsDataURL(file);
                    reader.onload = function () {
                        var id = 'blobid' + (new Date()).getTime();
                        var blobCache = tinymce.activeEditor.editorUpload.blobCache;
                        var base64 = reader.result.split(',')[1];
                        var blobInfo = blobCache.create(id, file, base64);
                        blobCache.add(blobInfo);
                        cb(blobInfo.blobUri(), { title: file.name });
                    };
                };
                input.click();
            },


            plugins: ["advlist autolink link image lists charmap print preview hr anchor pagebreak spellchecker", "searchreplace wordcount visualblocks visualchars code fullscreen insertdatetime media nonbreaking", "save table contextmenu directionality emoticons template paste textcolor"],
            toolbar: "insertfile undo redo | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image | print preview media fullpage | forecolor backcolor emoticons | fullscreen | code",
            style_formats: [{
                title: "Bold text",
                inline: "b"
            }, {
                title: "Red text",
                inline: "span",
                styles: { color: "#ff0000" }
                }, {
                title: "Red header",
                block: "h1",
                styles: {
                    color: "#ff0000"
                }
                }, {
                title: "Example 1",
                inline: "span",
                classes: "example1"
                }, {
                title: "Example 2",
                inline: "span",
                classes: "example2"
                }, {
                    title: "Table styles"
                }, {
                    title: "Table row 1",
                selector: "tr",
                classes: "tablerow1"
                }]
        })
});
