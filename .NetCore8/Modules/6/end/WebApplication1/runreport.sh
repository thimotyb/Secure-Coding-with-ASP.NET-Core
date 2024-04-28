#!/bin/bash

# Funzione per stampare l'uso corretto dello script
print_usage() {
    echo "Utilizzo: $0 <nome>"
    exit 1
}

# Verifica se è stato passato almeno un argomento
if [ $# -eq 0 ]; then
    print_usage
fi

# Legge il nome dall'argomento
name="$1"

# Stampa il saluto
echo "Ciao, $name!"
