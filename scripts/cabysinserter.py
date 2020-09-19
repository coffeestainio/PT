from csv import reader

FILE = 'codigos.csv'
EXPORT = 'sql.sql'
STATEMENT = ''; 

with open(EXPORT, 'w') as w:
    with open(FILE) as f: 
        csv_reader = reader(f)
        for line in csv_reader: 
            w.write(f"UPDATE Producto set cabys = '{line[1]}' where id_producto = {line[0]};\n")
