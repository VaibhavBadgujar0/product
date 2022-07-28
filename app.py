from flask import Flask
from flask import render_template

app=Flask(__name__)

headings=('Product Id','Name','Description')
data=(
    ('1001', 'Tool Gears', 'Gears tools production specification'),
    ('2001', 'Panels', 'Switch Gear Panels'),
    ('2008', 'DocTonar', 'Document Solar Objects'),
)

@app.route('/')
def table():
    return render_template('table.html', headings=headings, data=data)