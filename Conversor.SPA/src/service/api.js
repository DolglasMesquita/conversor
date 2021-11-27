import axios from "axios"

export const http = axios.create({
    baseURL: 'http://192.168.0.111:5000/api/'
})

export default {
    converterComprimento(medidaDestino, valor, medidaInicial) {
        return http.get(`comprimento/${medidaDestino}/${valor}/${medidaInicial}` )
    },

    converterTemperatura(temperaturaInicial, valor, temperaturaFinal) {
        return http.get(`temperatura/${temperaturaInicial}/${valor}/${temperaturaFinal}` )
    }

}