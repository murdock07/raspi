#!/usr/bin/python3
#keypassing.py
import encryptdecrypt as ENC

KEY1 = 20
KEY2 = 50

print ("Please enter text to scramble:")
#Get user input
user_input = input()
#Send message out
encodeKEY1 = ENC.encryptText(user_input,KEY1)
print ("USER1: Send message encrypted with KEY1 (KEY1): " + encodeKEY1)
#Reciever encrypts the message again
encodeKEY1KEY2 = ENC.encryptText(encodeKEY1,KEY2)
print ("USER2: Encrypt with KEY2 & returns it (KEY1+KEY2): " + encodeKEY1KEY2)
#Remove the original encoding
encodeKEY2 = ENC.encryptText(encodeKEY1KEY2,-KEY1)
print ("USER1: Removes KEY1 & returns it with just KEY2 (KEY2): " + encodeKEY2)
#Reciever removes their encryption
message_result = ENC.encryptText(encodeKEY2, -KEY2)
print ("USER2: Removes KEY2 & Message received: " + message_result)
#END
