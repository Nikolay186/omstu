import pandas as pd
import numpy as np
from pandas.core.frame import DataFrame

def read():
    df = pd.read_csv('football.csv')
    # print(df)
    return df

def process_data():
    df = read()

    def get_goals():
        print("Goals: ")
        print(df.loc[:, 'Goals'])
        print()

    def total_teams():
        print("Total teams: " + str(len(df)))
        print()

    def columns_rows():
        print("Rows and columns: " + str(df.shape))
        print()
    
    def discipline_df():
        print("Discipline dataframe: ")
        discipline = df.loc[:, ['Team', "Yellow Cards", "Red Cards"]]
        print(discipline)
        print()
        sort_discipline(discipline)

    def sort_discipline(disc: DataFrame):
        print("Sorted discipline dataframe: ")
        disc = disc.sort_values(['Red Cards', 'Yellow Cards'], ascending=True)
        print(disc)
        print()
    
    def average_cards_count():
        print("Average yellow cards count: ")
        print(df.loc[:, 'Yellow Cards'].mean())
        print()

    def get_six_goals_team():
        print(df.query('Goals > 6'))
        print()

    def get_g_team():
        print(df[df['Team'].str.startswith('G')])
        print()

    def first_seven_col():
        print(df.iloc[:, :7])
        print()

    def all_col_instead_of_last():
        print(df.iloc[:, :-3])
        print()

    def find_accuracy():
        countries = ["England", "Germany", "Russia"]
        for c in countries:
            print(c + ": " + str(df.query('Team == @c')['Shooting Accuracy']))

    get_goals()
    total_teams()
    columns_rows()
    discipline_df()
    average_cards_count()
    get_six_goals_team()
    get_g_team()
    first_seven_col()
    all_col_instead_of_last()
    find_accuracy()

if __name__ == "__main__":
    process_data()