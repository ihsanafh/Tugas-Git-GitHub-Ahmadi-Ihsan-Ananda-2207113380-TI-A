<template>
    <v-footer
        dark
        height="auto"
        id="footer"
        padless
    >
        <v-card
            class="flex"
            text
            tile
        >
            <v-card-title class="green darken-4">
                <strong class="subheading">Get connected with us on social networks!</strong>

                <v-spacer></v-spacer>

                <v-btn
                    v-for="icon in icons"
                    :key="icon"
                    class="mx-3"
                    dark
                    icon
                >
                    <v-icon size="24px">{{ icon }}</v-icon>
                </v-btn>
            </v-card-title>

            <v-card-actions class="green darken-3 justify-center">
                ©2018 - <strong>Universitas Riau</strong>
            </v-card-actions>
        </v-card>
    </v-footer>
</template>

<script>
    export default {
        data: () => ({
            icons: [
                'fab fa-facebook',
                'fab fa-twitter',
                'fab fa-google-plus',
                'fab fa-linkedin',
                'fab fa-instagram'
            ]
        })
    }
</script>
<style>
    #footer {
        position: absolute;
        bottom: 0;
        width: 100%;
        background-color: darkgreen;
    }
    .v-card__title {
        background-color: darkgreen;
    }
    .v-card__actions {
        justify-content: center;
    }
</style>