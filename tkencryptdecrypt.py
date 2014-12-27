#!/usr/bin/python3
#tkencryptdecrypt.py
import encryptdecrypt as ENC
import tkinter as TK

def encryptButton():
	encryptvalue.set(ENC.encryptText(encryptvalue.get(), keyvalue.get()))

def decryptButton():
	encryptvalue.set(ENC.encryptText(encryptvalue.get(), -keyvalue.get()))

#Define Tkinter application
root = TK.Tk()
root.title("Encrypt/Decrypt GUI")
#Set control & test value
encryptvalue = TK.StringVar()
encryptvalue.set("My message")
keyvalue = TK.IntVar()
keyvalue.set(20)
prompt = "Eneter message to encrypt:"
key = "Key:"

label1 = TK.Label(root,text=prompt,width = len(prompt),bg = 'green')
textEnter = TK.Entry(root, textvariable = encryptvalue, width = len(prompt))
encryptButton = TK.Button(root,text = "Encrypt", command = encryptButton)
decryptButton = TK.Button(root,text = "Decrypt", command = decryptButton)
label2 = TK.Label(root,text=key,width = len(key))
keyEnter = TK.Entry(root, textvariable = keyvalue, width = 8)

#Set layout
label1.grid(row = 0,columnspan = 1, sticky = TK.E + TK.W)
textEnter.grid(row = 1,columnspan = 1, sticky = TK.E + TK.W)
encryptButton.grid(row = 2,columnspan = 1, sticky = TK.E + TK.W)
decryptButton.grid(row = 3,columnspan = 1, sticky = TK.E + TK.W)
label2.grid(row = 4,columnspan = 1, sticky = TK.E + TK.W)
keyEnter.grid(row = 5,columnspan = 2, sticky = TK.E + TK.W)

TK.mainloop()
#End
