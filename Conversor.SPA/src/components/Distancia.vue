<template>
    <div class="pt-5">
        <div class="input-group mb-3">
        <select class="form-select form-control" v-model="unidadeAtual" aria-label="Default select example">
            <option selected value="0">Atual</option>
            <option value="mm">mm</option>
            <option value="cm">cm</option>
            <option value="m">m</option>
            <option value="km">km</option>
        </select>
        <input type="number" class="form-control" v-model="valor" placeholder="valor" aria-label="Text input with dropdown button">
        <select class="form-select form-control" v-model="unidadeFinal" aria-label="Default select example">
            <option selected value="0">Final</option>
            <option value="mm">mm</option>
            <option value="cm">cm</option>
            <option value="m">m</option>
            <option value="km">km</option>
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
            valor: null,
            resultado: null,
        }
    },
    methods: {
        converter() {
            Api.converterComprimento(this.unidadeFinal, this.valor, this.unidadeAtual).then((resultado) => {
                this.resultado = `${resultado.data} ${this.unidadeFinal}`
            })
        }
    }
}

</script>

<style>

</style>
