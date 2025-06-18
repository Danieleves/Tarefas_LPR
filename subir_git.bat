@echo off
echo ==========================
echo  COMMIT E PUSH PARA O GITHUB
echo ==========================

set /p MSG=Digite sua mensagem de commit: 

git add .
git commit -m "%MSG%"
git push origin main

echo ==========================
echo  COMANDO CONCLUÍDO!
echo ==========================
pause
