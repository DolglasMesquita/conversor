<template>
    <div class="pt-5">
        <div class="input-group mb-3">
        <select class="form-select" v-model="unidadeAtual" aria-label="Default select example">
            <option selected value="0">Atual</option>
            <option value="celsius">celsius</option>
            <option value="kelvin">kelvin </option>
            <option value="fahrenheit">fahrenheit</option>
        </select>
        <input type="number" class="form-control" v-model="valor" placeholder="valor" aria-label="Text input with dropdown button">
        <select class="form-select" v-model="unidadeFinal" aria-label="Default select example">
            <option selected value="0">Final</option>
            <option value="c">celsius</option>
            <option value="k">kelvin </option>
            <option value="f">fahrenheit</option>
        </select>
        </div>

        <div class="input-group mb-3">
            <button class="btn btn-primary" @click="converter()"> Calcular </button>  
            <input type="text" v-model="resultado" disabled class="form-control">
        </div>

        
    </div>
</template>

<script>

import Api from "@/service/api"

export default {

    data() {
        return {
            unidadeAtual: 0,
            unidadeFinal: 0,
            resultado: null,
            valor: null
        }
    },
    methods: {
        converter() {
            Api.converterTemperatura(this.unidadeAtual, this.valor, this.unidadeFinal).then((resultado) => {
                this.resultado = `${resultado.data} °${this.unidadeFinal}`;
            })
        }
    }
}

</script>

<style>

</style>
