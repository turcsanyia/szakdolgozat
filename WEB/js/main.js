$(document).ready(function () {

    // keresés gomb alapértelmezetten letiltásra kerül
    $('#keres').prop('disabled', true);

    // Regisztráció
    $('#reg').click(function (e) {
        e.preventDefault();

        let veznev = $('[name=veznev]').val();
        let kernev = $('[name=kernev]').val();
        let tajszam = $('[name=tajszam]').val();
        let jelszo = $('[name=jelszo]').val();
        let irszam = $('[name=irszam]').val();
        let telepules = $('[name=telepules]').val();
        let lakcim = $('[name=lakcim]').val();
        let telszam = $('[name=telszam]').val();
        let email = $('[name=email]').val();

        $.ajax({
            method: "post",
            url: "php/reg.php",
            data: {
                veznev: veznev,
                kernev: kernev,
                tajszam: tajszam,
                jelszo: jelszo,
                irszam: irszam,
                telepules: telepules,
                lakcim: lakcim,
                telszam: telszam,
                email: email
            },
            success: function (hibalista) {
                $('.hibalista').html('<span>' + hibalista + '</span>');

                if (hibalista === 'Helyes kitöltés!') {
                    location.href = "index.php";
                }
            },
            error: function (xhr) {
                console.log(xhr.status);
            }
        });
    });

    $.ajax({
        url: "php/profil.php",
        method: "get",
        success: function (form) {
            $('.profil').html(form);
        },
        error: function () {
            $('.profil').html("<p class='hiba2'>Nem sikerült az adatok letöltése...</p>")
        }
    });

    $('.profil-modositas').click(function (e) {
        e.preventDefault();

        let veznev = $('[name=veznev]').val();
        let kernev = $('[name=kernev]').val();
        let jelszo = $('[name=jelszo]').val();
        let irszam = $('[name=irszam]').val();
        let telepules = $('[name=telepules]').val();
        let lakcim = $('[name=lakcim]').val();
        let telszam = $('[name=telszam]').val();
        let email = $('[name=email]').val();

        $.ajax({
            method: "post",
            url: "php/profil_modositas.php",
            data: {
                veznev: veznev,
                kernev: kernev,
                jelszo: jelszo,
                irszam: irszam,
                telepules: telepules,
                lakcim: lakcim,
                telszam: telszam,
                email: email
            },
            success: function (hibalista) {
                $('.hibalista').html('<span>' + hibalista + '</span>');
            },
            error: function (xhr) {
                console.log(xhr.status);
            }
        });
    });

    // Keresés
    $('#keres').click(function () {
        let orvosId = $('.orvos-szures').find(':selected').data('id');
        let szolgaltatasId = $('.szolgaltatas-szures').find(':selected').data('id');

        $.ajax({
            url: "php/kereses.php",
            method: "post",
            data: {
                orvosId: orvosId,
                szolgaltatasId: szolgaltatasId
            },
            success: function (tablazat) {
                $('.tablazat').html(tablazat);
            },
            error: function (xhr) {
                alert(xhr.status);
            }
        });
    });

    // taj inputba kitöltésre kerül
    $('[name=taj]').keydown(function () {
        $('.hiba').text('');
    });

    // jelszó inputba kitöltésre kerül
    $('[name=password]').keydown(function () {
        $('.hiba').text('');
    });

    // Bejelentkezés
    $('#login').click(function (e) {
        e.preventDefault();

        let taj = $('[name=taj]').val();
        let password = $('[name=password]').val();

        $.ajax({
            method: "post",
            url: "php/login.php",
            data: {
                taj: taj,
                password: password
            },
            success: function () {
                location.href = "rendeleseim.php";
            },
            error: function () {
                $('.hiba').html('Helytelen taj szám vagy jelszó!');
            }
        });
    });

    // Kijelentkezés
    $('#logout').click(function () {
        $.ajax({
            url: "php/logout.php",
            method: "get",
            success: function () {
                location.href = "index.php";
            },
            error: function (xhr) {
                alert(xhr.status);
            }
        });
    });

    // Orvosok select betöltése
    $.ajax({
        url: "php/select_orvosok.php",
        method: "get",
        success: function (select) {
            $('.orvosok-select').html(select);
        },
        error: function () {
            $('.orvosok-select').html("<p class='hiba2'>Jelenleg nem működik a szűrés......<p>")
        }
    });

    // Szolgáltatások select betöltése
    $.ajax({
        url: "php/select_szolgaltatasok.php",
        method: "get",
        success: function (select) {
            $('.szolgaltatasok-select').html(select);
        },
        error: function () {
            $('.szolgaltatasok-select').html("<p class='hiba2'>Jelenleg nem működik a szűrés...</p>")
        }
    });

    // Igénybe vett szolgáltatások betöltése alapértelmezetten
    rendelesekListazasa();

    // Igénybe vett szolgáltatások betöltése eseményre
    $('#listazas').click(function () {
        rendelesekListazasa();
    });

    // Ha lenyitjuk az orvosok selectet
    $(document).on('change', '.orvos-szures', function () {
        gombokKezelese();
    });

    // Ha lenyitjuk a szolgáltatások selectet
    $(document).on('change', '.szolgaltatas-szures', function () {
        gombokKezelese();
    });
});

function rendelesekListazasa() {
    $.ajax({
        url: "php/rendelesek.php",
        method: "get",
        success: function (tablazat) {
            $('.tablazat').html(tablazat);
        },
        error: function () {
            $('.tablazat').html("<p class='hiba2'>Nem sikerült a táblázat letöltése...</p>")
        }
    });
}

function gombokKezelese() {
    if ($('.orvos-szures').find(':selected').data('id') === 0 &&
            $('.szolgaltatas-szures').find(':selected').data('id') === 0) {
        $('#keres').prop('disabled', true);
    } else {
        $('#keres').removeAttr('disabled');
    }
}
