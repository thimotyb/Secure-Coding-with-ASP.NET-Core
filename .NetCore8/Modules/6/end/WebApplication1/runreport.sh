#!/bin/bash

# Funzione per stampare l'uso corretto dello script
print_usage() {
    echo "Utilizzo: $0 --name <nome>"
    exit 1
}

# Verifica se sono stati passati argomenti
if [ $# -eq 0 ]; then
    print_usage
fi

# Analizza gli argomenti
while [[ $# -gt 0 ]]; do
    key="$1"

    case $key in
        --name)
            name="$2"
            shift
            ;;
        *)
            # Ignora argomenti sconosciuti
            ;;
    esac
    shift
done

# Verifica se il parametro --name è stato specificato
if [ -z "$name" ]; then
    echo "Errore: Il parametro --name non è stato specificato."
    print_usage
fi

# Stampa il saluto
echo "Ciao, $name!"
