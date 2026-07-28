from time import sleep

def retry(func):
    def wrapper(*args, **kwargs):
        error: Exception | None = None

        for i in range(3):
            try:
                return func(*args, **kwargs)
            except Exception as ex:
                error = ex
                wait_time = 0.5 * (i + 1)
                sleep(wait_time)
        
        raise error
    return wrapper