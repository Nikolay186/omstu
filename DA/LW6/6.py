import pandas as pd
import numpy as np

def read():
    df = pd.read_csv('alco.csv')
    return df

def process_data():
    df = read()
    # print an entire dataframe
    print(df)
    print('\n')

    # get all continents
    cont = []
    for c in df.loc[:, "continent"]:
        if c not in cont:
            cont.append(c)

    def get_columns():
        # column names
        cn = df.columns.values
        print(*cn)
        print()

    def get_indexes():
        # indexing
        print("LOC indexing: ")
        print(df.loc[[0]])
        print(df.loc[6:10]) # LOC returns row in range a : b(inclusive)
        print("\nILOC indexing: ")
        print(df.iloc[[1]])
        print(df.iloc[6:10]) # ILOC returns rows in range a : b(exclusive)
        print()
    
    def average_beer_consumption():
        m = 0
        # get average beer cosumption for each continent
        for c in cont:
            m = max(df.query('continent == @c').beer_servings.mean(), m)
        print("Average beer consumption: " + str(np.around(m, decimals=2)))
        print()

    def wine_consumption_stats():
        # get stats for each continent
        for c in cont:
            print("Wine consumption in " + c + ": " + str(df.query('continent == @c')['wine_servings'].sum()))
        print()

    def category_consumption_avg():
        alc = ['beer_servings', 'spirit_servings', 'wine_servings']
        print("Average consumptions: ")
        for c in cont:
            for a in alc:
                print(a + " in " + c + ": " + str(np.around(df.query('continent == @c')[a].mean(), decimals=2)))
        print()

    def category_consumption_median():
        alc = ['beer_servings', 'spirit_servings', 'wine_servings']
        print("Median consumptions: ")
        for c in cont:
            for a in alc:
                print(a + " in " + c + ": " + str(np.around(df.query('continent == @c')[a].median(), decimals=2)))
        print()

    def spirt_stats():
        print("Max, median and min for each continent: ")
        for c in cont:
            print("Max in " + c + ": " + str(np.around(df.query('continent == @c')['total_litres_of_pure_alcohol'].max(), decimals=2)))
            print("Median in " + c + ": " + str(np.around(df.query('continent == @c')['total_litres_of_pure_alcohol'].median(), decimals=2)))
            print("Min in " + c + ": " + str(np.around(df.query('continent == @c')['total_litres_of_pure_alcohol'].min(), decimals=2)))
        print()
    
    def max_avg_country():
        max = df.spirit_servings.max()
        print(df.query('spirit_servings == @max'))
        print()

    def no_alcohol_countries():
        print(df.query('total_litres_of_pure_alcohol == 0'))
        print()

    get_columns()
    get_indexes()
    average_beer_consumption()
    wine_consumption_stats()
    category_consumption_avg()
    category_consumption_median()
    spirt_stats()
    max_avg_country()
    no_alcohol_countries()

if __name__ == "__main__":
    process_data()