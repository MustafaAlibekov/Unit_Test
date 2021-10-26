import telebot
bot = telebot.TeleBot("2067229525:AAF8wEI6kRNRLdfR44YvG2xTJ1dWzMaJRew")


@bot.message_handler(content_types=['text', 'document', 'audio'])
def get_text_messages(message):
    if message.text.lower() == "привет":
        bot.send_message(message.from_user.id, "Привет")
    elif message.text.lower() == "/help":
        bot.send_message(message.from_user.id, "Тут должен быть список команд, но его пока нет ):")
    else:
        bot.send_message(message.from_user.id, "Неизвестная команда, напишите /help")


bot.polling(none_stop=True, interval=0)
