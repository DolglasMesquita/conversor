<template>
    <div>   
        <!-- As a heading -->
        <nav class="navbar navbar-dark bg-dark mb-5">
        <div class="container-fluid container p-2">
            <span class="navbar-brand mb-0 h1"> Conversor de medidas </span>
        </div>
        </nav>

        <div class="container">

            <ul class="nav nav-tabs" id="myTab" role="tablist">
                <li class="nav-item" role="presentation">
                    <button class="nav-link active" id="distancia-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">Distância</button>
                </li>
                <li class="nav-item" role="presentation">
                    <button class="nav-link" id="temperatura-tab" data-bs-toggle="tab" data-bs-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false">Temperatura</button>
                </li>
            </ul>

            <div class="tab-content" id="myTabContent">
            <div class="tab-pane fade show active row" id="home" role="tabpanel" aria-labelledby="distancia-tab">
                <distancia class="col-12 col-lg-6"/>
            </div>
            <div class="tab-pane fade row" id="profile" role="tabpanel" aria-labelledby="temperatura-tab">
                <temperatura class="col-12 col-lg-6"/>
            </div>

            </div>            

        </div>
    </div>
</template>

<script>

import distancia from '@/components/Distancia'
import temperatura from '@/components/Temperatura'

export default {
    components: {
        distancia, temperatura
    },

    data() {
        return {
            medida: 0
        }
    }
}

</script>

<style>

</style>
