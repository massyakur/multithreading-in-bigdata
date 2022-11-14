import pandas as pd

# import nltk
# nltk.download('stopwords')
from nltk.corpus import stopwords

stop_words = stopwords.words('english')

# read the csv file 
df = pd.read_csv('rows.csv')
# print(df[df.columns[4]])

# select columns and delete rows which there is null value
my_data = df[['Complaint ID','Product','Issue','Company','State','ZIP code']].dropna()

# remove stop words and punctuation
my_data['Product'] = my_data['Product'].apply(lambda x: ' '.join([word for word in x.split() if word not in (stop_words)]))
my_data['Product'] = my_data['Product'].str.replace(r'[^\w\s]+', '')

# export to new csv file
my_data.to_csv('all_rows.csv', index=False)

# print(my_data)