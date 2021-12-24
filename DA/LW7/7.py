import pandas as pd
from pandas.core.frame import DataFrame
import matplotlib.pyplot as plt
import seaborn as sns

def analyze():
    # read data
    gender_tr = pd.read_csv("gender_train.csv")
    mcc_codes = pd.read_csv("tr_mcc_codes.csv", ";")
    tr_types = pd.read_csv("tr_types.csv", ";")
    tr = pd.read_csv("transactions.csv", nrows=1000000)

    # merge tables
    transactions = pd.merge(tr, gender_tr, how="left")
    transactions = pd.merge(transactions, mcc_codes, how="inner")
    transactions = pd.merge(transactions, tr_types, how="inner")

    # delete unnecessary variables
    del gender_tr
    del mcc_codes
    del tr_types
    del tr

    # get hours
    transactions['tr_hour'] = [int(s[1][:2]) for s in transactions['tr_datetime'].str.split(' ')]
    # make buckets
    transactions['amount_backet'] = pd.qcut(transactions[transactions.amount < 0].amount, 5, labels=['Very High', 'High', 'Middle', 'Low', 'Very Low'])
    transactions['amount_backet'] = transactions['amount_backet'].cat.add_categories('Income').fillna('Income')
    # plot table
    plot_pivot_table(transactions.pivot_table(index='tr_hour', columns='amount_backet', values='gender'))


def plot_pivot_table(pivot_table):
    plt.figure(figsize=(9, 11))
    sns.heatmap(pivot_table, cmap="YlGnBu", annot=True,
                fmt='.3g')
    plt.xticks(fontsize=15)
    plt.yticks(rotation=0, fontsize=15)
    plt.xlabel('Bucket', size=18)
    plt.ylabel('Hour', fontsize=18)
    plt.title('Gender analysis per bucket and hour', fontsize=20)
    plt.show()

analyze()