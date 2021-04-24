# Power Search

O foco desse repositório é estudar o [Azure Cognitive Search](https://azure.microsoft.com/pt-br/services/search/) e o [Cognitive Services](https://azure.microsoft.com/en-us/services/cognitive-services/) que são duas ferramentas da [Microsoft](https://www.microsoft.com/) e estão disponíveis no portal do [Azure](https://azure.microsoft.com/).

Para deixar o estudo ainda mais interessante, resolvi tratar um caso real, que é a busca de documentos em uma empresa.

O objetivo do Power Search é facilitar a forma de armazenamento desses documentos. Nesse processo será possível utilizar o [Cognitive Services](https://azure.microsoft.com/en-us/services/cognitive-services/) para enriquecer o conteúdo extraindo dados de imagens, pessoas, organizações, localizações, etc.

<img src="https://github.com/rodrigogermano/powersearch/blob/main/docs/home.png" alt="drawing" style="width:200px;"/>

# Arquitetura

Para representar a arquitetura vou usar o [modelo C4](https://c4model.com/).

## C1 - System Context

![diagram](https://www.plantuml.com/plantuml/svg/0/ZLHDRnen4Br7odzmSm8fXKjFFOMcA8r46bGWLKzey1gmvBKt_Y0q_oRgkSTUSjq_rXcpNhn9rLOWxJBCctdpvjaNpeFreLId9s-avYeKWcszhzpxuT32ms0Z_JQiWXEM6-s5zWDkoY4KLeBUgL25uUMxjrC5sYzk9aC5NZYFeUKbPU_ze8gbJqyces-tY_dow_Nyqt8olXf__jZhKtmgh3Ew5rm0AyqvErkuK3_Xwnc-On4dDa4m9C31iaYXVYuCumgSasl9WNwOakdwvqueLjNFAoMv6PprszexYSMLVCHKYqNlif_KP2vA1ewLmfNug8GjfNFrB-7OFNOsB15YWW4NpXa6_qF4oXs6SXuGV2GmecTdF8vgvjCX8syAunX-OptfpXcnq_KFmzfvSXh7pXOtOAKt33TfWhU6PbfBbLFP28kh5CZXwl3sciwmRVE2sJr6KHdRzEjCM9HIIsnFsZ8QDGzGZrlM2J7_3_4RUh49VMRV7K9wQnlDM635gNb0BZC1bc-fmvHg-6IPyqPRt9rFqnI6XnAhehWasmgSODhaunowBCTxtrifivhXlc13Qeri2Oz2GuHJjvcaJ22j8V_FlQnJ0jzABIR8KqkzGUZD8S9IA2zNWGKcj9Me0fSDMJ94WQgzgXr7HVG7UkPbq0eLBhL-Yev4kIjhoC8e0geTOQwLzejGnsEO2Kos2Ce3vL5EzpZz8P74w9w216rEG8PPLCf0GOZZLb9sQzA_zqX-Rvla1di9NijDG6dJjkFU3eSQpHtIrTDFUXp1IUFsDk29IIYFt1E73DVnpn6DhYIaDZlJXHyADEswwEi2a-9T4t4kTt9qZDI5s8CT91fDbTVU6pVM4gnR1QznF7gPcMrZZmiS9jxalm40)


## C2 - Container

![diagram](https://www.plantuml.com/plantuml/svg/0/ZLKzRzim4Dq3v3zSFJb0QY-TEkNBJLBamwZj1fsCaqGh12HIuOUJjEYF2JfqwjWbg_vOxoZPeUAYRX10D7Lyxzsxu-d0EZJEbyNkpXkfqi9d0cwTg-pxuT3W_I2NxjOdtWgJQkM4SeDKbqFCZ4IrB7pbXyVlteuBL6vsUJ4iq0dhQ6j-JD4ebJ23Ae3lxbmSVhcUJUStvzEp-SNeT7Hrqj_Z_R4mLgk-jnwDrFlGcrbVFz6oHsk2iIBt0aX2YWQ2YFevqv0MQArSo1JvXov1rR-Mee2gVauAcUf1Rs-DlPG4NiYl56e8z7FqaqcceWIqK0fRqgCIffJMrh-5XJjYrh0I108m5TPgmFyHOkIIjc8Tw5qGSCZFJdef-HbdHugSphG5-Wzuqku3grFr3mthV68PByo6Qc2aqq2rrDuPpJajP15BoOMXOWhISDgiDkKCrpIlbDtHBZbZMhvEXbafbIHwzXOurNY3EQwXimLkY_cjl42okpDvj7HWVgIzoj0yzcL2llJ6-fxKJ0IQzBQt1zyu4kXltOJzXGdTcr7mZKZWiAgeHz19hLWJgjmN6EHzq4Q9b8cZbAshdnpr5F0-jaUNmT-gVigbGgYV5Uq2HSTYWkgk4gmasp8-PxOJxPHmH6L4JBxmAYLfv7s6p846Ex1GaN6ba461Bn483ZvEhg-6PzFfU9Fq9Ebdw311omK_QPVCEBBaCW4GJe8g3O34ILrdH86D28w3GrFYLq69IhNGjAv_XXfHk14v5rDpxlxbfhIzcAtkJ5j0rlL955516aDc94Bf9L87a2HfaJeNSeDBQZvVyYjotj2RPPWBdETabIVZ1PGeoN7e-2sQmkK_7ZFEzwYxHW-kdnGwcT0jnPpHLjcNr8hXr4HoPF0DutSsf1dXb9ZUKWakg6vAgfoENZOxiDgAuKAbXJAIgfBA1X6u6g4chx73JAJJH_oCOMW0L7ILwwSmXwXNAgCvOVAIxbWuPjjwi7VhqHlTafaLjcCq1tRdwBReTjfj2rjFegruyTpuTtXxW7kYMyZJRaTbElNhcdR9mjdMO9wBld2u4TK6T3cEcayL4zWN1jiKLwfCF3IZvcz8c-qoQhj1G1UDlhZD_Llrdncyik20p0dVtZy0)



# Referências

[Azure Cognitive Search](https://azure.microsoft.com/pt-br/services/search/) 

[Cognitive Services](https://azure.microsoft.com/en-us/services/cognitive-services/)

[The C4 model for visualising software architecture](https://c4model.com/)

[PlantUML - Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=jebbs.plantuml)

