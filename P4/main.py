from web3 import Web3
from web3.middleware import geth_poa_middleware 
from contract_info import abi, contract_address

w3 = Web3(Web3.HTTPProvider('http://127.0.0.1:8545'))
w3.middleware_onion.inject(geth_poa_middleware, layer=0)

def main():
     print(f"Баланс первого аккаунта: {w3.eth.get_balance('0x1B7661D8F474A14ee01E10a6059a623956CC79Bd')}")
     print(f"Баланс второго аккаунта: {w3.eth.get_balance('0x9b3Dc3BbDF295bb78518D9e76e6C05F04c24BfE2')}")
     print(f"Баланс третьего аккаунта: {w3.eth.get_balance('0x1F5b0f0bB6e3eCCc742b27dD66C75805482D7B35')}")
     print(f"Баланс чеивертого аккаунта: {w3.eth.get_balance('0x6d0720bA46224EAb09745bA51DF2982D34Bb155b')}")
     print(f"Баланс пятого аккаунта: {w3.eth.get_balance('0x52A960D9Ef8043d0F9e6772790004f51Ef010ff5')}")

if __name__ == '__main__':
    main()    
    